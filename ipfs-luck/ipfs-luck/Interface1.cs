using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipfs_luck 
{
    interface MyListener
    {
        void onReceive(byte[] input);
        void onReceive(string v);
    }
    class b : MyListener {

        public void a(MyListener input)
        {
            input.onReceive("mypacket");
        }

        public void onReceive(string v)
        {
            throw new NotImplementedException();
        }

        public void onReceive(byte[] input)
        {
            throw new NotImplementedException();
        }
        public void run()
        {
            for(;;)
            {
                
            }
        }
    }
}