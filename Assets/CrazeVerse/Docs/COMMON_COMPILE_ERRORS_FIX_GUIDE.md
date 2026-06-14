# Common Compile Errors Fix Guide

Fix one error at a time. Do not rush into gameplay work before compile errors are cleared.

## Namespace Mismatch

If Unity says a type cannot be found, check that the namespace is correct.

Examples:

- Training scripts use `CrazeVerse.Training`.
- Player scripts use `CrazeVerse.Player`.
- Combat planning scripts use `CrazeVerse.Combat` even though the folder fallback is `PlayerCombat`.
- UI scripts use `CrazeVerse.UI`.
- Core managers use `CrazeVerse.Core`.

## Missing Using Statement

If a script references a class from another namespace, add the correct `using` statement.

Examples:

- `using CrazeVerse.Player;`
- `using CrazeVerse.Combat;`
- `using CrazeVerse.Training;`
- `using CrazeVerse.UI;`

## Class And File Name Notes

Unity usually works best when MonoBehaviour class name and file name match.

Important known fallback:

- `TrainingDisplayData.cs` contains class `TrainingHUDData`.
- This is okay in C# because `TrainingHUDData` is a serializable data class, not a MonoBehaviour.
- If Unity or project style requires it later, rename the file locally in Unity or Cursor after compile checking.

## Fallback Folder Notes

Some exact folders were blocked during GitHub-only setup.

Examples:

- `PlayerCombat` is used as fallback for blocked `Combat` path.
- Some visual/data/config fallback folders were used earlier.

If exact folder names are needed later, create proper folders locally after Unity compile check. Do not delete fallback files until the project compiles cleanly.

## Best Fixing Rule

Fix the first red Console error, save, let Unity recompile, then continue to the next error.
