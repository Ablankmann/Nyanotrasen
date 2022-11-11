using Robust.Shared.Audio;

namespace Content.Server.Disease.Components;

/// <summary>
///     As of now, the disease server and R&D server are one and the same.
///     So, this is a research client that can look for DiseaseServer
///     on its connected server and print vaccines of the diseases stored there.
/// </summary>
[RegisterComponent]
public sealed class DiseaseVaccineCreatorComponent : Component
{
    public DiseaseServerComponent? DiseaseServer = null;

    /// <summary>
    /// Biomass cost per vaccine.
    /// </summary>
    [DataField("BiomassCost")]
    public int BiomassCost = 4;

    /// <summary>
    /// Current vaccines queued.
    /// </summary>
    public int Queued = 0;

    [DataField("runningSound")]
    public SoundSpecifier RunningSoundPath = new SoundPathSpecifier("/Audio/Machines/vaccinator_running.ogg");

}
