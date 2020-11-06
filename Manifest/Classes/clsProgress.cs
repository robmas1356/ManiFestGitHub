using System.Threading;

namespace Manifest
{
    class clsProgress
    {
        private static Thread th = new Thread(new ThreadStart(showProgressForm));
        public void startProgress()
        {
            th = new Thread(new ThreadStart(showProgressForm));

            th.Start();
        }

        private static void showProgressForm()
        {
            frmWaiting sForm = new frmWaiting();
            sForm.ShowDialog();
        }

        public void stopProgress()
        {
            th.Abort();
            th = null;
        }
    }
}
