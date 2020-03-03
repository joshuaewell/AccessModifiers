using System;
using AccessModifierProject;

namespace ThirdAccessModifierProject
{
    public class AssemblyCClass4 : AssemblyAClass1
    {
        // This demonstrates a private method is not visible outside
        // of the respective class.
        public string PrivateFunctionOfAssemblyAClass1()
        {
            //return A_PrivateFunction();
            return "AssemblyCClass4.A_PrivateFunction is not visible to this class";
        }

        // This demonstrates a public method is visible outside the respective
        // class and assembly, within the same application.
        public string PublicFunctionOfAssemblyAClass1()
        {
            return A_PublicFunction();
        }

        // This demonstrates a protected method is visible
        // outside of the class by those who have inherited it.
        public string ProtectedFunctionOfAssemblyAClass1()
        {
            return A_ProtectedFunction();
        }

        // This demonstrates an internal method is not accessible by
        // outside assemblies, even those which do inherit it.
        public string InternalFunctionOfAssemblyAClass1()
        {
            //return A_InternalFunction();
            return "AssemblyCClass4.A_InternalFunction is not visible to this class";
        }

        // This demonstrates a protected - internal method is accessible by an
        // outside assembly of a class which does inherit it.
        public string ProtectedInternalFunctionOfAssemblyAClass1()
        {
            return A_ProtectedInternalFunction();
        }

        // This demonstrates a private - protected class is not accessible
        // by an outside assembly.
        public string PrivateProtectedFunctionOfAssemblyAClass1()
        {
            //return A_PrivateProtectedFunction();
            return "AssemblyCClass4.A_PrivateProtectedFunction is not visible to this class";
        }
    }
}
