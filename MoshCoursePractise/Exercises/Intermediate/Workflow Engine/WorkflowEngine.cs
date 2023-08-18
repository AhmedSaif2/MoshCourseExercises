namespace MoshCourseExercises.Exercises.Intermediate
{
    public class WorkflowEngine
    {
        private readonly Workflow _workflow;
        public WorkflowEngine(Workflow workflow) 
        {
            _workflow = workflow;
        }
        public void ExecuteWorkflow()
        {
            _workflow.Execute();
        }
    }
}
