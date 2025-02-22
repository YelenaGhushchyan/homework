public class WorkoutSession
{
    public string exerciseType;
    public int durationInMinutes;

    public WorkoutSession(string exerciseType, int durationInMinutes)
    {
        this.exerciseType = exerciseType;
        this.durationInMinutes = durationInMinutes;
    }

    public void ShowWorkoutDetails()
    {
        Console.WriteLine("ExerciseType: " + exerciseType);
        Console.WriteLine("DurationInMinutes: " + durationInMinutes);
    }
}

class Program
{
    static void Main(string[] args)
    {
        WorkoutSession workout1 = new WorkoutSession("Running", 30);
        WorkoutSession workout2 = new WorkoutSession("Cycling", 45);
        WorkoutSession workout3 = new WorkoutSession("Yoga", 60);
        
        Console.WriteLine("Workout 1 Details:");
        workout1.ShowWorkoutDetails();

        Console.WriteLine("Workout 2 Details:");
        workout2.ShowWorkoutDetails();

        Console.WriteLine("Workout 3 Details:");
        workout3.ShowWorkoutDetails();
    }
}
