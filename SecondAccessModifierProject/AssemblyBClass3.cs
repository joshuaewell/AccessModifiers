using AccessModifierProject;

namespace SecondAccessModifierProject
{
    // AssemblyBClass3 does not inherit AssemblyAClass1
    public class AssemblyBClass3
    {
        // Instance of AssemblyAClass1
        public AssemblyAClass1 AssemblyAClass1 = new AssemblyAClass1();

        // This demonstrates a private method is not visible outside
        // of the respective class.
        public string PrivateFunctionOfAssemblyAClass1()
        {
            //return AssemblyAClass1.A_PrivateFunction();
            return "AssemblyAClass1.A_PrivateFunction is not visible to this class";
        }

        // This demonstrates a public method is visible outside the respective
        // class and assembly, within the same application.
        public string PublicFunctionOfAssemblyAClass1()
        {
             return AssemblyAClass1.A_PublicFunction();
        }

        // This demonstrates a protected method is not visible
        // outside of the class, or by those who have not inherited it.
        public string ProtectedFunctionOfAssemblyAClass1()
        {
            //return AssemblyAClass1.A_ProtectedFunction();
            return "AssemblyAClass1.A_ProtectedFunction is not visible to this class";
        }

        // This demonstrates an internal method is not accessible by
        // outside assemblies.
        public string InternalFunctionOfAssemblyAClass1()
        {
            //return AssemblyAClass1.A_InternalFunction();
            return "AssemblyAClass1.A_InternalFunction is not visible to this class";
        }

        // This demonstrates a protected - internal method is not accessible
        // outside of the assembly, or by a class which does not inherit it.
        public string ProtectedInternalFunctionOfAssemblyAClass1()
        {
            //return AssemblyAClass1.A_ProtectedInternalFunction();
            return "AssemblyAClass1.A_ProtectedInternalFunctionValue is not visible to this class";
        }

        // This demonstrates a private - protected class is not accessible
        // by an outside assembly.
        public string PrivateProtectedFunctionOfAssemblyAClass1()
        {
            //return AssemblyAClass1.A_PrivateProtectedFunction();
            return "AssemblyAClass1.A_PrivateProtectedFunctionValue is not visible to this class";
        }
    }
}