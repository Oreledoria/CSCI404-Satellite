using System;

namespace OrbitalCalculator.Services.models
{
    public interface IPropagationModel
    {
        SatelliteLocation getPosition();
    }
}