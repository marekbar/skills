/*
 * Skills and tasks project
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
namespace SkillsAndTasks
{
    /// <summary>
    /// Action to be taken
    /// </summary>
    interface Action
    {
        /// <summary>
        /// Save
        /// </summary>
        /// <returns>true - saved, false - saving failed</returns>
        bool save();

        /// <summary>
        /// Update
        /// </summary>
        /// <returns>true - updated, false - update failed</returns>
        bool update();

        /// <summary>
        /// Delete
        /// </summary>
        /// <returns>true - removed, false - removing failed</returns>
        bool delete();
    }
}
