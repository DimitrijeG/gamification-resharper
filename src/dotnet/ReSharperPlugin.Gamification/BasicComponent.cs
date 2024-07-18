using JetBrains.Lifetimes;
using JetBrains.ProjectModel;
using JetBrains.Util;

namespace ReSharperPlugin.Gamification;

[SolutionComponent]
public class BasicComponent
{
    public BasicComponent(Lifetime lf, ILogger logger)
    {
    }
}