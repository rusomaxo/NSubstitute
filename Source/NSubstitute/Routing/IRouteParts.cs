using System;
using NSubstitute.Core;

namespace NSubstitute.Routing
{
    public interface IRouteParts
    {
        ICallHandler GetPart<TPart>() where TPart : ICallHandler;
        ICallHandler CreatePart(Type partType);
    }
}