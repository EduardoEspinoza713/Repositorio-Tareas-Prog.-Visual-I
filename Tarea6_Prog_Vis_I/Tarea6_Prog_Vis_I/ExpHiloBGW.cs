using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarea6_Prog_Vis_I
{
    public static class ExpHiloBGW
    {
        public static ConditionalWeakTable<Thread, Thread> subhilo = new ConditionalWeakTable<Thread, Thread>();
        public static ConditionalWeakTable<BackgroundWorker, Thread> bgwSubH = new ConditionalWeakTable<BackgroundWorker, Thread>();
        public static void Aggsubhilo(this Thread hilo, Thread sub)
        {
            try
            {
                subhilo.Add(hilo, sub);
            }
            catch (Exception w)
            {
                subhilo.Remove(hilo);
                subhilo.Add(hilo, sub);
            }
        }
        public static void Aggsubhilo(this BackgroundWorker BGW, Thread sub)
        {
            try
            {
                bgwSubH.Add(BGW, sub);
            }
            catch (Exception w)
            {
                bgwSubH.Remove(BGW);
                bgwSubH.Add(BGW, sub);
            }
        }
        public static Thread miSubhilo(this Thread hilo)
        {
            Thread sub;
            if (subhilo.TryGetValue(hilo, out sub))
            {
                return sub;
            }
            return null;
        }
        public static Thread miSubhilo(this BackgroundWorker BGW)
        {
            Thread sub;
            if (bgwSubH.TryGetValue(BGW, out sub))
            {
                return sub;
            }
            return null;
        }
        public static void DetCasc(this Thread hilo)
        {
            hilo.Abort();
            (hilo.miSubhilo()).Abort();
        }
        public static void DetCasc(this BackgroundWorker BGW)
        {
            BGW.CancelAsync();
            (BGW.miSubhilo()).Abort();
        }
    }
}
