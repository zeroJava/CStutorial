using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.TaskMaster
{
    class Anagram
    {
        public static bool AreStringsAnagram1(string word1, string word2)
        {
            char[] _words1 = word1.ToCharArray();
            IList<char> _words2 = word2.ToCharArray().ToList();

            for(int index = 0; index < _words1.Length; index++)
            {
                _words2.Remove(_words1[index]);
            }

            if(_words2.Count > 0)
            {
                return false;
            }

            return true;
        }

        public static int IndexValueR2(string value)
        {
            char[] _letters = value.ToCharArray();
            int _index = 0;
            int _tempLength = 0;
            int _relLenght = 0;

            int index;
            for(index = 0; index < _letters.Length - 1; index++)
            {
                if(_letters[index] == _letters[index + 1])
                {
                    _tempLength++;
                }
                else
                {
                    if (_relLenght < _tempLength)
                    {
                        _relLenght = _tempLength;
                        _index = index - _tempLength + 1;
                    }
                    _tempLength = 0;
                }
            }

            if (_relLenght < _tempLength)
            {
                _relLenght = _tempLength;
                _index = index - _tempLength + 1;
            }

            return _index;
        }

        public static int Jump3(int distance)
        {
            return distance;
        }
    }
}
