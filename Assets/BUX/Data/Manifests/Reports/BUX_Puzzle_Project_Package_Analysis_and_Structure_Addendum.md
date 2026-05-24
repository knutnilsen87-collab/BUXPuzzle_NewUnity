# Aegis Project Package Analysis

Generated: 2026-05-22

## Executive assessment

This package is strong as a full-production product/spec handoff. It already defines the product promise, major mechanics, release acceptance criteria, technical direction, and Codex handoff expectations.

The most important existing decisions are correct:
- Reuse the existing match-3 engine if `BoardEngine` is authoritative and separable.
- Keep gameplay deterministic for same-board challenges.
- Keep animations, companion reactions, cosmetics, and UI out of authoritative gameplay rules.
- Use data/config for levels, tiles, rewards, cosmetics, worlds and events.
- Treat the first public version as a complete release, not a prototype.

## Main gap found

The package needs a stronger implementation architecture addendum for the current Unity repo. The existing docs explain the product and high-level architecture, but Codex needs stricter guidance on:

1. Target Unity repo structure and ownership boundaries.
2. Theme-pack architecture for multiple visual worlds using the same engine.
3. Canonical gameplay invariants, especially player-executable valid moves.
4. Blocked/locked tile semantics and visual clarity.
5. Level solvability and no-dead-board validation.
6. Verification gates before success claims.
7. Safe implementation order that avoids broad rewrites and repo entropy.

This addendum supplies those missing constraints.

## What Codex should not do

Codex must not:
- rewrite the whole match-3 engine without first proving it is necessary;
- fork gameplay rules per theme;
- create `NatureBoardEngine`, `CandyBoardEngine`, etc.;
- let visual theme assets define legality, blockers, scoring, swaps, objectives, or solvability;
- count blocked/non-swappable tiles as valid moves;
- treat historical docs or logs as current verification;
- claim success without fresh Unity compile/runtime/validation evidence.

## Recommended source-of-truth order after this addendum

1. `00_START_HERE/Document_Priority_and_Source_of_Truth.md`
2. `02_Product/PRD_Product_Requirements_Document.md`
3. `02_Product/Game_Mechanics_Tile_Specification.md`
4. `04_Technical/Technical_Architecture_Spec.md`
5. `04_Technical/Gameplay_Invariants_and_Solvability_v1.md`
6. `04_Technical/Theme_Pack_Architecture_v1.md`
7. `04_Technical/Unity_Repo_Structure_and_Package_Ownership.md`
8. `06_QA/Acceptance_Criteria.md`
9. `06_QA/Validation_Gates_for_Codex.md`
10. `11_Handoffs/Aegis_Codex_Master_Execution_Prompt.md`

## Critical architectural decisions to lock

### 1. One canonical gameplay engine

`BoardEngine` and related core systems own gameplay truth. Presentation, themes, UI, audio, companion, economy, and social systems react to resolved gameplay outputs.

### 2. Themes are data/assets only

Themes may own visuals, UI colors, fonts, audio, VFX and board presentation. They must not own independent gameplay rules.

### 3. Valid move means player-executable move

A move is valid only when the player can actually perform it:
- cells are adjacent and in bounds;
- both cells are swappable;
- neither cell is blocked/locked/frozen/immovable;
- swap creates a match or allowed special activation.

### 4. No-dead-board invariant

The player must never regain control if the stable board has zero player-executable moves.

### 5. Verification gates are mandatory

Every meaningful patch must end with:
- Unity compile/open;
- runtime smoke;
- solvability validation;
- release validation;
- relevant visual/manual check when UI/presentation is changed;
- updated `status_bundle.txt`.

## Recommended first execution sequence

1. **Audit current repo and create/update `status_bundle.txt`.**
2. **Protect current verified state.** Identify required untracked files before any feature work.
3. **Patch blocked tile clarity and valid move semantics.**
4. **Harden board liveness and solvability validation.**
5. **Add theme wrapper architecture around existing NatureLight assets.**
6. **Only then begin broader content/theme expansion.**

## Highest-risk current product areas

- Blocked/locked tile visual clarity.
- Valid move detection that may count non-executable blocked moves.
- No-dead-board recovery after cascades/spawns.
- High-level generated/JSON level solvability.
- Theme expansion causing engine-rule forks.
- UI readability and modal/HUD visual polish.
- Clean-checkout reproducibility if required files are untracked.


---

# Theme Pack Architecture v1

## Purpose

BUX Puzzle should support multiple visual themes while using one shared match-3 engine.

Examples:
- NatureLight
- CandyGarden
- SpaceGrove
- IceCavern
- HoneyHarvest seasonal theme

## Core architecture decision

Themes are data/assets only. Themes must not define independent gameplay rules.

```text
One engine.
Many themes.
No theme-specific BoardEngine.
```

## Theme responsibilities

A theme may own:

- tile sprites;
- special tile sprites;
- blocker overlays;
- board background;
- board panel/surface/cell slot sprites;
- fonts;
- UI colors;
- UI sprites;
- modal/HUD styling;
- audio clips/music;
- VFX prefabs;
- animation style hints.

A theme must not own:

- swap legality;
- match detection;
- blocker HP rules;
- objective completion;
- scoring;
- reward calculation;
- seeded randomness;
- level solvability;
- challenge fairness.

## Recommended theme structure

```text
Assets/Game/Themes/
  _Shared/
    ThemeDefinition.cs
    ThemeCatalog.cs
    TileSetConfig.cs
    UIThemeConfig.cs
    BoardThemeConfig.cs
    AudioThemeConfig.cs
    VfxThemeConfig.cs

  NatureLight/
    NatureLight.theme.asset
    TileSet_NatureLight.asset
    UITheme_NatureLight.asset
    BoardTheme_NatureLight.asset
    AudioTheme_NatureLight.asset
    VfxTheme_NatureLight.asset
    Sprites/
      Tiles/
      Board/
      UI/
      Blockers/
    Audio/
    Fonts/

  CandyGarden/
    CandyGarden.theme.asset
    TileSet_CandyGarden.asset
    UITheme_CandyGarden.asset
    BoardTheme_CandyGarden.asset
    AudioTheme_CandyGarden.asset
    Sprites/
    Audio/
    Fonts/
```

## ThemeDefinition contract

Recommended ScriptableObject:

```csharp
public sealed class ThemeDefinition : ScriptableObject
{
    public string ThemeId;
    public string DisplayName;

    public TileSetConfig TileSet;
    public BoardThemeConfig Board;
    public UIThemeConfig UI;
    public AudioThemeConfig Audio;
    public VfxThemeConfig Vfx;
}
```

## ThemeCatalog contract

```csharp
public sealed class ThemeCatalog : ScriptableObject
{
    public ThemeDefinition DefaultTheme;
    public List<ThemeDefinition> Themes;
}
```

Theme selection may be based on:
- level/world;
- player choice;
- seasonal event;
- test/debug setting.

## UIThemeConfig contract

Recommended fields:

```csharp
public sealed class UIThemeConfig : ScriptableObject
{
    public Font DisplayFont;
    public Font BodyFont;

    public Color Primary;
    public Color PrimaryDark;
    public Color Accent;
    public Color CardBackground;
    public Color TextDark;
    public Color TextLight;

    public Sprite HudBadgeSprite;
    public Sprite HudPanelSprite;
    public Sprite ModalCardSprite;
    public Sprite PrimaryButtonSprite;
}
```

Rules:
- Display font is for titles and primary buttons.
- Body font is for scores, reward values, objective text, progress text, and small labels.
- Small text must prioritize readability over style.

## BoardThemeConfig contract

Recommended fields:

```csharp
public sealed class BoardThemeConfig : ScriptableObject
{
    public Sprite Background;
    public Sprite BoardPanel;
    public Sprite CellSlot;
    public Sprite CellStateNormal;
    public Sprite CellStateBlocked;
    public Sprite CellStateMoss;
    public Sprite CellStateLocked;
    public Sprite SelectionRing;
    public Sprite HintRing;
}
```

## Blocked tile visual rule

Every non-swappable cell/tile state must have a clear visual marker.

Nature theme examples:
- vines/root overlay;
- moss tint;
- locked root ring;
- darker/desaturated tile base.

Candy theme examples:
- frosting overlay;
- chocolate lock;
- sugar web.

Ice theme examples:
- ice shell;
- frost ring.

The visual mapping changes per theme. The gameplay state does not.

## Runtime wiring

Recommended dependency flow:

```text
GameRoot / ThemeService
  -> ThemeDefinition
     -> BoardView / BoardPresentationController
     -> TileView
     -> SimpleHud
     -> ResultScreenOverlay
     -> GameAudioController
```

Forbidden dependency flow:

```text
BoardEngine -> ThemeDefinition
BoardEngine -> Sprite
BoardEngine -> AudioClip
BoardEngine -> UIThemeConfig
```

## Wrapper-first migration

Do not move many existing assets in the first patch if that risks `.meta` churn or broken references.

First step:
- add `ThemeDefinition`;
- create `NatureLight.theme.asset`;
- reference existing `TileSet_NatureLight.asset` and current UI/audio config in place;
- extend validation to assert all required refs exist.

Second step:
- migrate assets into `Assets/Game/Themes/NatureLight/` only when safe.

## Addressables

Do not start with Addressables unless necessary.

Use direct ScriptableObject references for the first implementation.

Consider Addressables later when:
- themes are downloadable;
- asset size becomes large;
- seasonal content needs live delivery;
- remote config selects content.

## Theme validation

Add or extend validation to check:

- every theme has a unique `ThemeId`;
- `DefaultTheme` exists;
- all required configs are assigned;
- all core tile visual IDs have sprites;
- blocked/locked/moss/root states have visible overlays;
- UI has display and body fonts;
- audio required events have clips or explicit silent fallbacks;
- game can load level 1 with the default theme;
- missing references fail loudly.

## Success criteria

Theme architecture is successful when:
- NatureLight is loaded through `ThemeDefinition` or a safe wrapper;
- BoardEngine is unchanged and theme-agnostic;
- UI/board/audio read theme configs;
- missing theme refs are caught by validation;
- runtime smoke and release validation still pass.

