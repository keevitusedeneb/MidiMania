using Melanchall.DryWetMidi.Smf;
using Melanchall.DryWetMidi.Smf.Interaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MidiMania
{
    class MidiParser
    {
        private MidiFile mf;
        private List<Note> notes = new List<Note>();
        private List<Note> RightHandNotes = new List<Note>();
        private List<Note> LeftHandNotes = new List<Note>();


        public void parseMidi()
        {
            mf = MidiFile.Read(Program.filePath);
            parseNotes();
        }

        private void parseNotes()
        {

            foreach (var note in mf.GetNotes())
            {
                notes.Add(note);
            }
        }

        public List<Note> getNotes()
        {
            return notes;
        }

        public TempoMap getTempoMap()
        {
            return mf.GetTempoMap();
        }

        public void parseRightHandNotes()
        {

            foreach (var note in getNotes())
            {
                if (note.NoteNumber >= 60)
                {
                    RightHandNotes.Add(note);
                }
            }
        }

        public void parseLeftHandNotes()
        {

            foreach (var note in getNotes())
            {
                if (note.NoteNumber < 60)
                {
                    LeftHandNotes.Add(note);
                }
            }
        }

        public List<Note> getRightHandNotes()
        {
            return RightHandNotes;
        }

        public List<Note> getLeftHandNotes()
        {
            return LeftHandNotes;
        }
    }
}
