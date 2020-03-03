
namespace AccessModifierProject
{
    // AssemblyAClass1 is inherited by AssemblyAClass2
    public class AssemblyAClass2 : AssemblyAClass1
    {
        // This demonstrates a private method is not visible outside
        // of the respective class.
        public string PrivateFunctionOfAssemblyAClass1()
        {
            //return A_PrivateFunction();
            return "AssemblyAClass1.A_PrivateFunction is not visible to this class";
        }

        // This demonstrates a public method is visible outside the respective
        // class and within the same assembly.
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

        // This demonstrates an internal method is accessible by
        // the same assembly.
        public string InternalFunctionOfAssemblyAClass1()
        {
            return A_InternalFunction();
        }

        // This demonstrates a protected - internal method is accessible
        // by a class which does inherit it.
        public string ProtectedInternalFunctionOfAssemblyAClass1()
        {
            return A_ProtectedInternalFunction();
        }

        // This demonstrates a private - protected class is accessible
        // by a class in the same assembly, which inherits it.
        public string PrivateProtectedFunctionOfAssemblyAClass1()
        {
            return A_PrivateProtectedFunction();
        }
    }
}