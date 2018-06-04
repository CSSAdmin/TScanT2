//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by this guidance package as part of the solution template
//
// The DependentModuleInfo class implements the ModuleInfo for the DependentModuleLoader service
// 
// For more information see: 
// ms-help://MS.VSCC.v90/MS.VSIPCC.v90/ms.practices.scsf.2008apr/SCSF/html/03-01-010-How_to_Create_Smart_Client_Solutions.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.Practices.CompositeUI.Configuration;

namespace TerraScan.Infrastructure.Library.Services
{
    public class DependentModuleInfo : ModuleInfo, IDependentModuleInfo
    {
        string _name = null;
        List<string> _dependencies = new List<string>();

        public DependentModuleInfo()
        {
        }

        public DependentModuleInfo(string assemblyFilename)
            : base(assemblyFilename)
        {
        }

        public List<string> Dependencies
        {
            get { return _dependencies; }
        }

        IList<string> IDependentModuleInfo.Dependencies
        {
            get { return Dependencies; }
        }

        public string Name
        {
            get { return _name; }
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }
}