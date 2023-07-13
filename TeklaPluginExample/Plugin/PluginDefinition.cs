using System.Collections.Generic;
using Tekla.Structures.Model;
using Tekla.Structures.Plugins;
using OSCB.Helpers;
using OSCB.Viewmodels;

namespace OSCB.Plugin
{
    [Plugin(BaseData.PLUGIN_NAME)]
    [PluginUserInterface("OSCB.UI." + BaseData.PLUGIN_WINDOW_NAME)]
    public class PluginDefinition : PluginBase
    {

        #region Private Helpers

        private DefineInputs DefineInputs { get; set; } = new DefineInputs();
        private GetInputs GetInputs { get; set; }= new GetInputs();

        private PluginInitiator PluginInitiator { get; set; } = new PluginInitiator();
        #endregion


        #region Private Fields

        private string _Typeverbinding;

        #endregion

        #region Properties

        public Model Model { get; set; }
        public DemoViewViewModel Data { get; set; }

        #endregion

        public PluginDefinition(DemoViewViewModel data)
        {
            Model = new Model();
            Data = data;
        }

        #region Overrides
        public override List<InputDefinition> DefineInput()
        {
            return DefineInputs.SelectModelPart();
        }

        public override bool Run(List<InputDefinition> Input)
        {
            GetValuesFromDialog();
            return PluginInitiator.Run(Input);
        }
        #endregion

        #region Private methods
        private void GetValuesFromDialog()
        {
            _Typeverbinding = Data.Typeverbinding;
            if (IsDefaultValue(_Typeverbinding)) _Typeverbinding = "";
        }

        #endregion
    }
}
