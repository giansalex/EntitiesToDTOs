using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell.Interop;
using EnvDTE;
using EnvDTE80;
using EntitiesToDTOs.Generators;

namespace EntitiesToDTOs.Events
{
    public class ProgressVisualStudio
    {
        #region Fields
        private static IVsStatusbar StatusBar;

        private static bool _initialized = false;

        private uint _cookie = 0;
        #endregion
        public static void Initialize(IVsStatusbar bar)
        {
            if(_initialized == false)
            {
                _initialized = true;
                StatusBar = bar;
            }
        }
        public ProgressVisualStudio()
        {

        }
        /// <summary>
        /// Inicia ProgresBar de Visual Studio
        /// </summary>
        /// <param name="FileName"></param>
        public void Start(string FileName)
        {
            GeneratorManager.OnProgress += new EventHandler<GeneratorOnProgressEventArgs>(GeneratorManager_OnProgress);
            GeneratorManager.OnException += new EventHandler<GeneratorOnExceptionEventArgs>(GeneratorManager_OnException);
            StatusBar.SetColorText("File : " + FileName, 0 ,0);
        }

        /// <summary>
        /// Executed when <see cref="GeneratorManager"/> fires an OnException event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GeneratorManager_OnException(object sender, GeneratorOnExceptionEventArgs e)
        {
            //this.Close();
            ClearProgresBar();
        }

        /// <summary>
        /// Executed when the <see cref="GeneratorManager"/> fires an OnProgress event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GeneratorManager_OnProgress(object sender, GeneratorOnProgressEventArgs e)
        {
            StatusBar.Progress(ref _cookie, 1, e.StatusMessage, (uint)e.Progress, 100);
        }

        private void ClearProgresBar()
        {
            // Clear the progress bar. 
            StatusBar.Progress(ref _cookie, 0, "", 0, 0);
            StatusBar.FreezeOutput(0); 
            StatusBar.Clear(); 
        }
        /// <summary>
        /// Finaliza el ProgressBar de Visual Studio
        /// </summary>
        public void EndProgress()
        {
            ClearProgresBar();
        }
    }
}
