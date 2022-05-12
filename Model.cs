namespace Mvu.Experiment;

public class Model
{
    public Model(int count, int stepSize)
    {
        Count = count;
        StepSize = stepSize;
    }

    public int Count { get; }
    public int StepSize { get; }
}