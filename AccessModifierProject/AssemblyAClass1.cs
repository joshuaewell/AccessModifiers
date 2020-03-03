namespace AccessModifierProject
{
    public class AssemblyAClass1
    {
        // This is only accessible by this class
        private string A_PrivateFunction()
        {
            return "A_PrivateFunctionValue";
        }

        // This demonstrates a private method is only accessible by
        // the same class
        public string A_PublicFunctionToAccessAPrivateFunction()
        {
            return A_PrivateFunction();
        }

        // This is accessible by all classes in the same 
        // assembly or by classes in other assemblies within the
        // same application.
        public string A_PublicFunction()
        {
            return "A_PublicFunctionValue";
        }

        // This is only accessible by this class or
        // by classes which inherit from it.
        protected string A_ProtectedFunction()
        {
            return "A_ProtectedFunctionValue";
        }

        // This is only accessible by this class or any class
        // within the same assembly.
        internal string A_InternalFunction()
        {
            return "A_InternalFunctionValue";
        }

        // This is only accessible by this class or any class within
        // the same assembly, or by any external assembly which
        // inherits this class.
        protected internal string A_ProtectedInternalFunction()
        {
            return "A_ProtectedInternalFunctionValue";
        }

        // This is only accessible by this class or another class
        // within the same assembly which inherits this class.
        private protected string A_PrivateProtectedFunction()
        {
            return "A_PrivateProtectedFunctionValue";
        }
    }
}