# Step 5 Core Managers and Local Services

This step adds architecture skeletons only for the local-first Unity prototype.

## Core Managers Added

Core managers were added under `Assets/CrazeVerse/Scripts/Core/` as simple Unity `MonoBehaviour` skeletons. Each manager has `IsReady` and `Init()` so future steps can initialise systems in a clean order.

Managers include game startup, scene loading, local save coordination, player profile, economy, missions, matches, matchmaking, bots, squad, UI, audio, settings, localisation, rewards, inventory, fair-play checks, reports, download status, events, and offline AI content planning.

## Service Interfaces Added

Service interfaces were added under `Assets/CrazeVerse/Scripts/Services/` to keep the prototype backend-ready without requiring a backend now.

Interfaces include local account, profile, matchmaking, leaderboard, inventory, economy, friends, clan/group, shop, events, analytics, offline AI content, and a data-store fallback.

## Local Mock Services Added

Local mock services return safe local values only. They do not use network calls, Firebase, backend, payment, multiplayer server, or OpenAI API.

These services make the first prototype work locally before real online services are connected later.

## Data Models Added

The following local-save-friendly data models were added:

- `PlayerProfileData`
- `MatchRequestData`
- `RewardData`
- `MissionData`

## Local-First Rule

The first build must use guest session, local profile, local save, local coins, local XP, local rank, local bots, local matchmaking simulation, local leaderboard mock, local shop mock, and local mission data.

## Future Replacement Plan

Later, after the local prototype works, the interfaces can be replaced or adapted for Firebase, a backend service, cloud profile sync, real leaderboard, real friends/clan data, analytics, and future OpenAI-powered content services.

## Next Step

Step 6 is the UI navigation shell. It should create screen navigation structure only, not gameplay systems.
