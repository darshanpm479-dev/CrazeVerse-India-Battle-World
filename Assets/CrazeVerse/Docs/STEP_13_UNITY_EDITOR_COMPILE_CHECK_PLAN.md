# Step 13 Unity Editor Compile Check Plan

This step is GitHub-only. Unity Editor was not run from this chat, and no real compile check was performed here.

The real compile check must be done later on the local computer after opening the project in Unity.

## Recommended Unity Setup

- Recommended Unity version: Unity 6 LTS.
- If Unity 6 LTS is not available, use the latest stable Unity 2022 LTS or Unity 2023 LTS.
- Template: 3D URP.
- Platform: Android.
- Scripting: C#.

## First Local Compile Check Flow

1. Open Unity Hub.
2. Open or import this GitHub project folder.
3. Wait for Unity to import assets.
4. Let Unity compile scripts fully.
5. Open the Console window.
6. Check Console errors.
7. Fix compile errors before starting gameplay work.
8. Do not add Firebase, backend, payment, or OpenAI API now.
9. Do not create APK until compile errors are zero.

## Important Rule

The first target is not gameplay. The first target is clean Unity compilation with zero red Console errors.
