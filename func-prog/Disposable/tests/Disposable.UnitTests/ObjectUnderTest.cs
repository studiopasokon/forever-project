using System;

namespace StudioPasokon.ForeverProject.FuncProg.Tests
{
    /// <summary>
    /// This class <see cref="ObjectUnderTest"/> implements the <see cref="IDisposable"/> interface so that
    /// it can be used within the unit test of <see cref="UsingTests"/>.
    /// </summary>
    internal class ObjectUnderTest : IDisposable
    {
        /// <summary>
        /// Flag representing the instantiation of the <see cref="ObjectUnderTest"/>.
        /// </summary>
        public static bool s_objectConstructed;

        /// <summary>
        /// Flag representing the disposing of managed objects.
        /// </summary>
        public static bool s_managedObjectsDisposed;

        /// <summary>
        /// Flag representing the disposing of unmanaged objects.
        /// </summary>
        public static bool s_unmanagedObjectsDisposed { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public ObjectUnderTest()
        {
            s_objectConstructed = true;
            s_managedObjectsDisposed = false;
            s_unmanagedObjectsDisposed = false;
        }

        /// <summary>
        /// Function that simply returns the value it receives as input.
        /// This is added to be able to add a function call within the unit test.
        /// </summary>
        /// <param name="input">An integer as test value.</param>
        /// <returns>The value received as input.</returns>
        public int GetResult(int input) => input;

        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    s_managedObjectsDisposed = true;
                }

                s_unmanagedObjectsDisposed = true;
                // For the unit test, a finaliser override isn't necessary.

                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~ObjectUnderTest()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}