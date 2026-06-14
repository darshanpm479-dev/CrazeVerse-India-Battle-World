# Step 6 UI Navigation Shell

This step adds the UI navigation shell architecture only.

## Added

- `ScreenId` enum for all planned menu and game UI screens.
- `UIPageBase` as the base class for UI pages.
- `UIScreenRouter` as the local navigation controller.
- `UIStackHistory` for simple back navigation state.
- Loading overlay, modal dialog, and toast message skeletons.
- Top bar and bottom navigation skeleton views.
- Main menu shell to connect router, top bar, bottom nav, loading overlay, and modal.
- Placeholder screen classes for the first shell pages.

## ScreenId Purpose

`ScreenId` gives every screen a stable identifier. This keeps the future Unity UI data-driven and avoids hardcoded string navigation.

## UIPageBase Purpose

`UIPageBase` provides `Show`, `Hide`, and `Refresh` methods with a visibility state. Future screens should inherit from it.

## UIScreenRouter Purpose

`UIScreenRouter` stores the current screen and supports local navigation with `NavigateTo` and `GoBack`. It does not load Unity scenes yet.

## UIStackHistory Purpose

`UIStackHistory` keeps simple screen history for back navigation.

## Top Bar and Bottom Nav

`TopBarView` stores title, coins, and level values. `BottomNavView` stores selected tab state and can show or hide itself.

## Placeholder Screens

Placeholder screens were created for splash, login, home lobby, mode selection, Ghost Hunt entry, mission list, Battle Royale lobby, TDM lobby, Zombie Survival lobby, Race Battle lobby, Custom Room, Training Ground, account/profile, settings, and match results.

## Rules Followed

- No Unity scene files were created.
- No Canvas prefabs were created.
- No gameplay logic was added.
- No player movement, weapons, ghost AI, zombie AI, vehicles, multiplayer, payment, backend, Firebase, or OpenAI API was added.
- Visual style must follow root `UI_STYLE_GUIDE.md` and Canva Deck 1 to Deck 5 later.

## Next Step

Step 7 will wire local profile and save data or continue with the Home Lobby UI skeleton, depending on the approved roadmap.
