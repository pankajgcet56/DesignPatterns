namespace Solid.State
{
    public class SolidStateConstants
    {
        public static int ErrorStateMachineNotStarted = 1000;
        public static int ErrorTriggerNotValidForState = 1001;
        public static int ErrorMultipleGuardClausesAreTrue = 1002;
        public static int ErrorNoGuardClauseIsTrue = 1003;
        public static int ErrorStateResolverCouldNotResolveType = 1004;
        public static int ErrorNoStatesHaveBeenConfigured = 1005;
        public static int ErrorStatesNeedParameterlessConstructor = 1006;
        public static int ErrorStateMachineIsStarted = 1007;
        public static int ErrorMultipleInitialStates = 1008;
        public static int ErrorCannotMixGuardedAndGuardlessTransitions = 1009;
        public static int ErrorTriggerAlreadyConfiguredForState = 1010;
    }
}