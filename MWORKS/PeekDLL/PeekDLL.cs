using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    public class PeekDLL
    {
        private List<String> _images = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };

        public void fInit()
        {
            for (int i = 1; i <= 30; i++)
            {
                _images[i - 1] = null;
            }
        }

        public void fAdd(int nPos,String sFName)
        {
            _images[nPos - 1] = sFName;
        }

        public String fGet(int nPos)
        {
            return _images[nPos - 1];
        }
    }
}
