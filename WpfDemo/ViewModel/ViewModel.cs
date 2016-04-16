using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo
{
    public class ViewModel
    {
        #region Fields

        #endregion

        #region Constructors

        public ViewModel()
        {
            Model = new Model();
        }


        #endregion


        #region Properties

        // To access Model all namespaces must be changed to WpfDemo
        public Model Model { get; set; }
        public ActionCommand ButtonClick { get; set; }


        #endregion


        #region Methods


        #endregion
    }
}
