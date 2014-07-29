﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TomiSoft.RolandStyleReader;
using Midi;

namespace StyleDemo {
	public partial class Form1 : Form {
		private RolandStyle style;

		public Form1() {
			InitializeComponent();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Roland style (*.stl)|*.stl";

			if (dlg.ShowDialog() == DialogResult.OK) {
				this.style = new RolandStyle(dlg.FileName);

				this.lStyleName.Text = this.style.Name;
				this.lSignature.Text = this.style.Signature.ToString() + " formátumú stílus";
				this.lMetronomeMark.Text = this.style.Measure.ToString();
				this.lTempo.Text = this.style.Tempo + " BPM";

				this.pbBeat.Maximum = this.style.Measure.Numerator;

				lwMessages.Items.Clear();

				float a = (this.style.Tempo * 120) / 60000f;

				foreach (MidiMessage msg in this.style[true, StylePart.Intro, TomiSoft.RolandStyleReader.Instrument.Drum, ChordType.Major]) {
					ListViewItem lwi = new ListViewItem(StyleTime.FromStyleMessage(msg, this.style).ToString());
					lwi.SubItems.Add(msg.MessageType.ToString());
					lwi.SubItems.Add(msg.Channel.ToString());

					switch (msg.MessageType) {
						case MidiMessageType.ControlChange:
							TomiSoft.RolandStyleReader.ControlChangeMessage ccm = (TomiSoft.RolandStyleReader.ControlChangeMessage)msg;
							lwi.SubItems.Add(ccm.Control.ToString());
							lwi.SubItems.Add(ccm.Value.ToString());
							break;

						case MidiMessageType.ProgramChange:
							TomiSoft.RolandStyleReader.ProgramChangeMessage pcm = (TomiSoft.RolandStyleReader.ProgramChangeMessage)msg;
							lwi.SubItems.Add(pcm.MSB.ToString());
							lwi.SubItems.Add(pcm.LSB.ToString());
							lwi.SubItems.Add(pcm.Program.ToString());
							break;

						case MidiMessageType.Note:
							TomiSoft.RolandStyleReader.NoteMessage nm = (TomiSoft.RolandStyleReader.NoteMessage)msg;
							lwi.SubItems.Add(nm.Name + " " + nm.Octave);
							lwi.SubItems.Add(nm.Velocity.ToString());
							lwi.SubItems.Add(nm.Length.ToString());
							break;
					}

					lwMessages.Items.Add(lwi);
				}
			}
		}

		private Midi.Message ToMessage(MidiMessage m, OutputDevice device, Clock clock, out float time) {
			float a = (this.style.Tempo * 120) / 60000f;
			
			TomiSoft.RolandStyleReader.NoteMessage msg = (TomiSoft.RolandStyleReader.NoteMessage)m;
			time = msg.TotalTime / 120f;

			return new NoteOnOffMessage(
				device,
				Channel.Channel10,
				(Pitch)((msg.Note < 128) ? msg.Note : 1),
				msg.Velocity,
				msg.TotalTime / 120f,
				clock,
				msg.Length
			);
			
		}

		private void btnPlay_Click(object sender, EventArgs e) {
			OutputDevice dev = OutputDevice.InstalledDevices[0];
			dev.Open();
			Clock clock = new Clock(this.style.Tempo);

			dev.SendProgramChange(Channel.Channel10, Midi.Instrument.SteelDrums);

			float LastMsgTime = 0;

			foreach (var CurrentMessage in this.style[true, StylePart.Intro, TomiSoft.RolandStyleReader.Instrument.Drum, ChordType.Major]) {
				if (CurrentMessage.MessageType == MidiMessageType.Note) {
					clock.Schedule(this.ToMessage(CurrentMessage, dev, clock, out LastMsgTime));
				}
			}

			clock.Start();

			while (clock.Time <= LastMsgTime) {
				System.Threading.Thread.Sleep(50);
				StyleTime t = StyleTime.FromStyleTimestamp((int)(clock.Time * 120), this.style);
				label1.Text = t.ToString();
				pbBeat.Value = t.Beat;
				Application.DoEvents();
			}

			clock.Stop();
			dev.Close();

			pbBeat.Value = 0;
		}
	}
}