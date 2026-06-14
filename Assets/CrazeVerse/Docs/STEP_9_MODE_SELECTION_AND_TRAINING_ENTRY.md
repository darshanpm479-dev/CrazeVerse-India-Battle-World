# Step 9 Mode Selection and Training Entry

This step adds local mode selection and training ground entry architecture for the CrazeVerse Unity prototype.

## Added

- GameModeId enum for the seven planned modes.
- GameModeData for mode names, target screens, squad size, player-count planning, bot-fill planning, unlock state, featured state, and default map.
- MapOptionData for fictional India-inspired map choices.
- ModeSelectionState for selected mode, selected map, readiness, and status message.
- ModeSelectionController for local mode/map selection and local MatchRequestData creation.
- TrainingOptionData for training menu options.
- TrainingGroundEntryController for selecting a training preview option.

## Updated

- ModeSelectionScreen now has an optional ModeSelectionController reference and refresh hook.
- TrainingGroundScreen now has an optional TrainingGroundEntryController reference and refresh hook.

## Ghost Hunt Squad Player Plan

- MVP target: 24 players, 6 squads x 4.
- Advanced clean max: 48 players, 12 squads x 4.
- Future scalable target: up to 50 players after real multiplayer/server optimisation.
- Clean squad size remains 4.
- No real multiplayer is created in this step.

## Not Added

- No Unity Canvas was created.
- No prefabs were created.
- No Unity scenes were created.
- No gameplay match start was added.
- No player controller was added.
- No weapon system was added.
- No ghost, zombie, or vehicle systems were added.
- No backend, Firebase, OpenAI API, or payment dependency was added.

## Visual Direction Later

Future visual work must follow UI_STYLE_GUIDE.md and the approved Canva Deck 1 to Deck 5 references.

## Next Step

Step 10 will create the player controller skeleton after approval.
