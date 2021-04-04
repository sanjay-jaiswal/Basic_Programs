using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class StopWatch
    {
        private DateTime _start;
        private DateTime _stop;
        //bool by deflaut is false
        private bool _running;

        //Console.WriteLine(now.ToString("HH:mm:ss"));

        // DateTime.Now is okay as long the local machine doesnt cause harm
        //Don't use Date.Now to measure benchmark code
        // Use datetime.UTCNow for records, precise and unambiguous way

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("Stop watch is running...");
            }

            _running = true;
            _start = DateTime.Now;

        }

        public void Stop()
        {

            if (!_running)
            {
                throw new InvalidOperationException("Stop watch is not running!!");
            }
            _running = false;
            _stop = DateTime.Now;
        }

        public void Calculate()
        {
            //Calculated elapsed time
            Console.WriteLine("Elapsed time is : ");
            TimeSpan total = _start - _stop;


            Console.WriteLine(total);

        }

    }
}
