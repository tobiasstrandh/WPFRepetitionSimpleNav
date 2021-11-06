using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using WPFRepetition.Models;

namespace WPFRepetition.ViewModels
{
    class CenterViewModel : ObservableObject
    {
        #region Fields

        private DataModel _dataModel;

        #endregion

        #region Properties

        private int _counter;

        public int Counter
        {
            get { return _counter; }
            set => SetProperty(ref _counter, value);
        }

        #endregion

        #region Commands

        

        #endregion

        public CenterViewModel(DataModel dataModel)
        {
            _dataModel = dataModel;
            InstanciateCommands();
        }


        private void InstanciateCommands()
        {
            throw new NotImplementedException();
        }
    }
}
