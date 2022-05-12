namespace Mvu.Experiment;

public record Message { };
public record Increment : Message { };
public record Decrement : Message { };
public record SetStepSize(int StepSize) : Message { };
public record Reset : Message { };