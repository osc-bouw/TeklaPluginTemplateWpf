﻿#pragma checksum "..\..\..\UI\OSCB_DemoView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CACD54919EC543922BFCEDC8E30D628C4CC34797CA91B51554B3CD47E586C70D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Fusion.UI;
using OSCB.UI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tekla.Structures.Dialog;
using Tekla.Structures.Dialog.UIControls;


namespace OSCB.UI {
    
    
    /// <summary>
    /// OSCB_DemoView
    /// </summary>
    public partial class OSCB_DemoView : Tekla.Structures.Dialog.PluginWindowBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\UI\OSCB_DemoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OSCB.UI.OSCB_DemoView pwb_local;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UI\OSCB_DemoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tekla.Structures.Dialog.UIControls.WpfSaveLoad saveload;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\UI\OSCB_DemoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TeklaPluginExample;component/ui/oscb_demoview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\OSCB_DemoView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pwb_local = ((OSCB.UI.OSCB_DemoView)(target));
            return;
            case 2:
            this.saveload = ((Tekla.Structures.Dialog.UIControls.WpfSaveLoad)(target));
            
            #line 42 "..\..\..\UI\OSCB_DemoView.xaml"
            this.saveload.HelpOpenClicked += new System.EventHandler(this.WpfSaveLoad_HelpOpenClicked);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\UI\OSCB_DemoView.xaml"
            this.saveload.AttributesSaveClicked += new System.EventHandler(this.WpfSaveLoad_AttributesSaveClicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            
            #line 50 "..\..\..\UI\OSCB_DemoView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WpfOkApplyModifyGetOnOffCancel_OkClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 51 "..\..\..\UI\OSCB_DemoView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WpfOkApplyModifyGetOnOffCancel_ApplyClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 52 "..\..\..\UI\OSCB_DemoView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WpfOkApplyModifyGetOnOffCancel_ModifyClicked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 53 "..\..\..\UI\OSCB_DemoView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WpfOkApplyModifyGetOnOffCancel_GetClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

