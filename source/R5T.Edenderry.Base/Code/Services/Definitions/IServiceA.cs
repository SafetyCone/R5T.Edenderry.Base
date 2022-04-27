using System;

using R5T.T0064;


namespace R5T.Edenderry
{
    [ServiceDefinitionMarker]
    public interface IServiceA : IServiceDefinition
    {
        string GetA();
    }
}
