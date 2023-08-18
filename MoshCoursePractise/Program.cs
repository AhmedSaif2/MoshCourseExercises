using MoshCourseExercises.Exercises.Advanced;
using MoshCourseExercises.Exercises.Advanced.Delegates;
using MoshCourseExercises.Exercises.Beginner;
using MoshCourseExercises.Exercises.Intermediate;


var workflow = new Workflow();
workflow.AddActivity(new UploadActivity());
workflow.AddActivity(new ProcessingActivity());
workflow.AddActivity(new SendEmailActivity());
WorkflowEngine workflowEngine = new WorkflowEngine(workflow);
workflowEngine.ExecuteWorkflow();
