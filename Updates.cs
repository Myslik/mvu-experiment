namespace Mvu.Experiment;

public static class Updates
{
    public static Model Update(this Model model, Message message) =>
        message switch
        {
            Increment => new Model { Count = model.Count + model.StepSize, StepSize = model.StepSize },
            _ => throw new NotImplementedException()
        };
}