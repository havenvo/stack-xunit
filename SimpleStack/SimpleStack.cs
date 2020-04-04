using System.Collections.Generic;

namespace SimpleStack {
    public class Stack : IStack {
        private List<string> data;

        public Stack () {
            data = new List<string> ();
        }

        public void Clear () {
            data.Clear ();
        }

        public bool Contains (string value) {
            return data.Contains (value);
        }

        public bool IsEmpty () {
            return data.Count == 0;
        }

        public string Peek () {
            if (IsEmpty ()) {
                throw new StackEmptyException ();
            }
            return data[data.Count - 1];
        }

        public string Pop () {
            if (IsEmpty ()) {
                throw new StackEmptyException ();
            }
            var result = data[data.Count - 1];
            data.Remove (result);
            return result;
        }

        public void Push (string value) {
            data.Add (value);
        }
    }
}