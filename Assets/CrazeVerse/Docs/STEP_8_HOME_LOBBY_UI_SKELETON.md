# Step 8 Home Lobby UI Skeleton

This step adds the Home Lobby and main page UI architecture for the local Unity prototype.

## Added

- HomeLobbyData for player summary, selected mode, selected map, mode cards, quick actions, news banners, and daily reward preview.
- ModeCardData for local mode cards.
- HomeQuickActionData for simple main page actions.
- NewsBannerData for local banner previews.
- DailyRewardPreviewData for daily reward preview values.
- HomeLobbyController for building home data from local save data.
- HomeNavigationActions for routing home buttons to ScreenId values.

## Updated

- HomeLobbyScreen now has an optional HomeLobbyController reference and refresh hook.
- MainMenuShell now has an optional HomeLobbyController reference and home refresh support.

## Not Added

- No Unity Canvas was created.
- No prefabs were created.
- No Unity scenes were created.
- No player controller was added.
- No gameplay match start was added.
- No weapons, ghosts, zombies, or vehicles were added.
- No online service, cloud service, external AI service, or payment service was added.

## Visual Direction

The future visual implementation must follow UI_STYLE_GUIDE.md and the approved Canva Deck 1 to Deck 5 references.

## Next Step

Step 9 will create local mode selection and training ground entry skeleton after approval.
