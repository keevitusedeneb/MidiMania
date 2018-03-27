using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melanchall.DryWetMidi;
using Melanchall.DryWetMidi.Smf.Interaction;
using Midi;

namespace MidiMania
{
    //responsible for playing the music
    class Metronome
    {
        public List<Melanchall.DryWetMidi.Smf.Interaction.Note> notes = new List<Melanchall.DryWetMidi.Smf.Interaction.Note>();
        private OutputDevice outputDevice = OutputDevice.InstalledDevices[0];
        private TempoMap tempoMap;
        private int lastPlayedNote = 0;

        public Metronome(TempoMap tempoMap)
        {
            this.tempoMap = tempoMap;
        }

        public void openOutputDevice()
        {
            outputDevice.Open();
        }

        public void closeOutputDevice()
        {
            outputDevice.Close();
        }


        private void playANote(Melanchall.DryWetMidi.Smf.Interaction.Note note)
        {
            outputDevice.SendNoteOn((Channel)(short)note.Channel, (Pitch)(short)note.NoteNumber, 27+Settings.volume);
            
        }

        public void playASheet(List<Melanchall.DryWetMidi.Smf.Interaction.Note> notes)
        {
            if (!isEndOfList(notes.Count(),lastPlayedNote))
            {
                for (int i = lastPlayedNote; i < notes.Count; i++)
                {

                    if (Helper.timeConversion(notes[i].Time, tempoMap) / Settings.songSpeed >= Clock.elapsedTime)
                    {
                        lastPlayedNote = i;
                        break;
                    }

                    playANote(notes[i]);
                    lastPlayedNote = i + 1;

                }
                
            }

            

        }

        private bool isEndOfList(int ListCount, int i)
        {
            if (i == ListCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
