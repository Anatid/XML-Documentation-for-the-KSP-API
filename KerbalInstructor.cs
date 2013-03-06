#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// A KerbalInstructor object controls the animated image of a kerbal instructor
/// in a TutorialScenario. KerbalInstructors come with a stock emote animations
/// that you can trigger by calling the appropriate functions.
/// </summary>
public class KerbalInstructor : MonoBehaviour
{
    public Animation anim;
    public CharacterAnimationState anim_false_disagreeA;
    public CharacterAnimationState anim_false_disagreeB;
    public CharacterAnimationState anim_false_disagreeC;
    public CharacterAnimationState anim_false_disappointed;
    public CharacterAnimationState anim_false_sadA;
    public CharacterAnimationState anim_idle;
    public CharacterAnimationState anim_idle_lookAround;
    public CharacterAnimationState anim_idle_sigh;
    public CharacterAnimationState anim_idle_wonder;
    public CharacterAnimationState anim_true_nodA;
    public CharacterAnimationState anim_true_nodB;
    public CharacterAnimationState anim_true_smileA;
    public CharacterAnimationState anim_true_smileB;
    public CharacterAnimationState anim_true_thumbsUp;
    public CharacterAnimationState anim_true_thumbUp;
    public Transform AnimationRoot;
    public string CharacterName;
    public bool DrawDebugPanel;
    public Camera instructorCamera;
    public Material PortraitRenderMaterial;

    public extern KerbalInstructor();

    /// <summary>
    /// Presumably, makes the instructor execute a given animation.
    /// </summary>
    /// <param name="st">The animation to execute.</param>
    public extern void PlayEmote(CharacterAnimationState st);
    /// <summary>
    /// Presumably, makes the instructor execute a given animation repeatedly.
    /// </summary>
    /// <param name="st">The animation to exectue.</param>
    /// <param name="repeatInterval">How often to repeat the animation, in seconds?</param>
    public extern void PlayEmoteRepeating(CharacterAnimationState st, float repeatInterval);
    [ContextMenu("Reset Animations")]
    public extern void SetupAnimations();
    /// <summary>
    /// Presumably, makes the instructor stop repeating whatever animation
    /// you last told it to repeat.
    /// </summary>
    public extern void StopRepeatingEmote();
}
