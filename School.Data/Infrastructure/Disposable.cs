using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable() {
            Dispose(false);

        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);


        }

        private void Dispose(bool isDisposing) {
            if (!isDisposed && isDisposing) {
                DisposeCore()
            }

        }

        protected virtual void DisposeCore() {
        }



    }
}
