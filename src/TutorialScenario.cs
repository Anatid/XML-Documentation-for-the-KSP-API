#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A TutorialScenario is a ScenarioModule with some added features that
/// are useful for building tutorials or similar kinds of scenarios. A TutorialScenario
/// comes with a builtin in finite state machine for running the scenario and
/// displays "tutorial pages" in a GUI window alongside a picture of a friendly Kerbal instructor.
/// You can take advantage of all these features by making your ScenarioModule a subclass of
/// TutorialScenario.
/// 
/// See HarvesteR's example code in his forum article: 
/// 
/// http://forum.kerbalspaceprogram.com/content.php/121-Writing-Tutorials-A-Demo-%28and-some-source-code%29
/// </summary>
public class TutorialScenario : ScenarioModule
{
    protected GameObject arrowPrefab;
    protected List<TutorialArrow> arrows;
    protected TutorialScenario.TutorialPage currentPage;
    public string guiSkinName;
    /// <summary>
    /// Controls the animated image of the kerbal instructor. This object lets you make the instructor run
    /// various animations .
    /// </summary>
    public KerbalInstructor instructor;
    public int instructorPortraitSize;
    /// <summary>
    /// Set this string in OnAssetSetup to specify which instructor kerbal will appear
    /// in the tutorial window. The value "Instructor_Gene" gives Gene Kerman as the
    /// instructor. The default if you do not specify anything is Werner von Kerman.
    /// </summary>
    public string instructorPrefabName;
    public RenderTexture instructorTexture;
    public int textureBorderRadius;
    /// <summary>
    /// The finite state machine that controls the progression of the tutorial.
    /// </summary>
    protected TutorialScenario.TutorialFSM Tutorial;
    public string tutorialArrowPrefabName;

    public extern TutorialScenario();

    protected extern void ClearArrows();
    protected extern TutorialArrow CreateArrow();
    protected extern void DeleteArrow(TutorialArrow arrow);
    protected extern void Destroy(global::UnityEngine.Object obj);
    /// <summary>
    /// Override this function to run some initialization code?
    /// </summary>
    protected extern virtual void OnAssetSetup();
    /// <summary>
    /// Override this function to run some code as the tutorial
    /// is being set up.
    /// </summary>
    protected extern virtual void OnTutorialSetup();
    /// <summary>
    /// Sets the location of the GUI window of the tutorial.
    /// </summary>
    /// <param name="r"></param>
    protected extern void SetDialogRect(Rect r);

    /// <summary>
    /// The TutorialFSM provides a convient interface for implementing the meat of
    /// your scenario logic through a finite state machine. The states of the state
    /// machine are "pages." 
    /// </summary>
    [Serializable]
    public class TutorialFSM : KerbalFSM
    {
        /// <summary>
        /// The page that the tutorial was on before this one.
        /// </summary>
        public TutorialScenario.TutorialPage lastPage;
        /// <summary>
        /// The list of all pages in the tutorial.
        /// </summary>
        public List<TutorialScenario.TutorialPage> pages;

        public extern TutorialFSM();

        /// <summary>
        /// Add a page (a new possible state) to the tutorial.
        /// </summary>
        /// <param name="st">The page to add.</param>
        public extern void AddPage(TutorialScenario.TutorialPage st);
        /// <summary>
        /// Add a page (a new possible state) to the tutorial, but outside
        /// the default page sequence that will be used by GoToLastPage and 
        /// GoToNextPage.
        /// </summary>
        /// <param name="st">The page to add.</param>
        public extern void AddState(TutorialScenario.TutorialPage st);
        /// <summary>
        /// Transition the tutorial to the page before the current one in the default page sequence.
        /// </summary>
        public extern void GoToLastPage();
        /// <summary>
        /// Transition the tutorial to the page after current one in the default page sequence.
        /// </summary>
        public extern void GoToNextPage();
        /// <summary>
        /// Start the finite state machine on the page with the given name.
        /// </summary>
        /// <param name="initialPageName">The name of the page to start on.</param>
        public extern void StartTutorial(string initialPageName);
        /// <summary>
        /// Start the finite state machine on the given page.
        /// </summary>
        /// <param name="initialPage">The page to start one.</param>
        public extern void StartTutorial(TutorialScenario.TutorialPage initialPage);
    }

    /// <summary>
    /// TutorialPages are the states in the TutorialFSM finite state machine.
    /// They extend the KFSMState class, which represents a class in a more general 
    /// finite state machine, to add tutorial-related features like a Callback in which
    /// you draw the GUI of the tutorial page. 
    /// 
    /// <seealso cref="KFSMState"/>
    /// </summary>
    public class TutorialPage : KFSMState
    {
        /// <summary>
        /// Presumably, this KFSMEvent will be triggered when the function you passed to SetAdvanceCondition
        /// returns true. This should give you the opportunity to go to a page besides the default next
        /// page when the advance condition is met.
        /// </summary>
        public KFSMEvent onAdvanceConditionMet;
        /// <summary>
        /// Assign this Callback to a function that uses GUILayout to draw the GUI of this tutorial page.
        /// Whatever you do here gets draw inside the tutorial window, next to the picture of the 
        /// Kerbal instructor.
        /// </summary>
        public Callback OnDrawContent;
        /// <summary>
        /// Is this event triggered when GoToLastPage is called? Perhaps it gives you a chance to 
        /// go to a page besides the default previous page?
        /// </summary>
        public KFSMEvent onStepBack;
        /// <summary>
        /// The title displayed for this page.
        /// </summary>
        public string windowTitle;

        /// <summary>
        /// Create a new tutorial page with a given name. Note that the name of the page
        /// is distinct from its title.
        /// </summary>
        /// <param name="name">The name of the new page.</param>
        public extern TutorialPage(string name);

        /// <summary>
        /// You can call this function and pass to it a function that takes a KFSMState
        /// and returns a boolean. That function will be called every update cycle while
        /// this tutorial page is active. If the function ever returns true, the tutorial
        /// will automatically advance to the next page.
        /// </summary>
        /// <param name="condition"></param>
        public extern void SetAdvanceCondition(KFSMEventCondition condition);
    }
}
