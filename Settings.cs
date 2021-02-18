using System;
using System.Collections.Generic;
using System.IO;

namespace PLSQL_Crack_Pass
{
    internal class Settings
    {
        private List<string> _data = new List<string>();

        public Settings(string file)
        {
            var ret = File.ReadAllLines(file);
            var inSection = false;

            foreach (var line in ret)
            {
                if (line == "[LogonHistory]" || line == "[CurrentConnections]")
                {
                    //we've found the right part, time to process it
                    inSection = true;
                    continue;
                }
                else if (line == string.Empty || line.StartsWith("["))
                {
                    //if we have an empty line, or the start of a section, we aren't in the right section
                    inSection = false;
                    continue;
                }
                else if (inSection)
                {
                    //we're in the right section, so grab the line
                    _data.Add(line);
                }
            }
        }

        public List<string> GetLogins()
        {
            var ret = new List<string>();

            foreach (var line in _data)
            {
                ret.Add(_Decrypt(line));
            }

            return ret;
        }

        private static string _Decrypt(string scrambled)
        {
            var values = new List<int>();
            var ret = string.Empty;

            for (var i = 0; i < scrambled.Length; i += 4)
            {
                values.Add(Convert.ToInt32(scrambled.Substring(i, 4)));
            }

            var key = values[0];
            values.RemoveAt(0);
            for (var i = 0; i < values.Count; i++)
            {
                var val = values[i] - 1000;
                var mask = key + (10 * (i + 1));

                ret += (char)((val ^ mask) >> 4);
            }

            return ret;
        }
    }
}
