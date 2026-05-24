# Game Asset Audit

Kilde: `unsorted/game_asset_filenames.txt`

Oppsummering:

- `OK`: filen finnes med riktig navn.
- `OK - annet navn`: asseten finnes, men filnavnet matcher ikke listen.
- `VISUELL MATCH`: asseten ligger i `unsorted` med generisk Gemini-navn og passer visuelt best til ønsket navn.
- `DELVIS`: en relatert asset finnes, men den er ikke en ren/komplett match for ønsket fil.
- `MANGLER`: jeg fant ingen tydelig match.

## Etter navneoppretting

Jeg opprettet 35 nye korrekt navngitte filer som kopier/crops av de beste matchene. Originalfilene er beholdt.

Disse filene er nå samlet i egen mappe:

`renamed_matched_assets/`

Etter første runde:

- 54 av 85 ønskede filnavn fantes med korrekt navn når `renamed_matched_assets/` tas med.
- 31 filnavn manglet fortsatt.

Etter andre runde med nye bilder i `unsorted/` og `unsorted/unsorted ny/`:

- 16 nye ønskede assets ble lagt til i `renamed_matched_assets/`.
- 51 filer ligger nå i `renamed_matched_assets/`.
- 70 av 85 ønskede filnavn finnes nå med korrekt navn når hele prosjektet tas med.
- 15 filnavn mangler fortsatt fordi jeg ikke fant noen tydelig visuell match.

Fortsatt manglende filnavn:

- `blocker_vine_cut_02.png`
- `objective_basket_empty.png`
- `objective_basket_fill_01.png`
- `objective_basket_fill_02.png`
- `objective_honey_pot_cracked.png`
- `objective_honey_pot_empty.png`
- `objective_acorn_nest_empty.png`
- `objective_acorn_nest_fill_01.png`
- `objective_acorn_nest_fill_02.png`
- `objective_acorn_nest_full.png`
- `special_rocket_horizontal.png`
- `special_rocket_vertical.png`
- `ui_button_close.png`
- `chest_star_closed.png`
- `chest_friend_open.png`

## Treffliste

| Ønsket fil | Status | Beste match | Notat |
|---|---|---|---|
| blocker_ice_full.png | OK | blocker_ice_full.png | Eksakt filnavn. |
| blocker_ice_cracked.png | OK | blocker_ice_cracked.png | Eksakt filnavn. |
| blocker_vine_full.png | OK | blocker_vine_full.png | Eksakt filnavn. |
| blocker_vine_cut_01.png | OK | blocker_vine_cut_01.png | Eksakt filnavn. |
| blocker_vine_cut_02.png | MANGLER |  | Fant bare `blocker_vine_cut_01.png`. |
| blocker_stone_full.png | OK - annet navn | blocker_pebble_full.png | Ser ut som samme blocker-type, men kalt pebble. |
| blocker_stone_cracked_01.png | OK - annet navn | blocker_pebble_cracked_01.png | Ser ut som stone/pebble cracked 01. |
| blocker_stone_cracked_02.png | OK - annet navn | blocker_pebble_cracked_02.png | Ser ut som stone/pebble cracked 02. |
| objective_basket_empty.png | MANGLER |  | Fant bare full basket-tile. |
| objective_basket_fill_01.png | MANGLER |  | Ingen tydelig fyll-steg. |
| objective_basket_fill_02.png | MANGLER |  | Ingen tydelig fyll-steg. |
| objective_basket_full.png | DELVIS | TILES/basket_tile.png | Full kurv finnes, men ikke med objective-navn/variantsett. |
| objective_honey_pot_cracked.png | MANGLER |  | Ingen cracked variant. |
| objective_honey_pot_open.png | DELVIS | TILES/honey_pot_tile.png | Honningkrukke finnes, men ikke tydelig som separat open-objective-state. |
| objective_honey_pot_empty.png | MANGLER |  | Ingen empty variant. |
| objective_acorn_nest_empty.png | MANGLER |  | Fant acorn tile, men ikke acorn nest. |
| objective_acorn_nest_fill_01.png | MANGLER |  | Ingen nest fill variant. |
| objective_acorn_nest_fill_02.png | MANGLER |  | Ingen nest fill variant. |
| objective_acorn_nest_full.png | MANGLER |  | Ingen full acorn nest. |
| special_rocket_base.png | DELVIS | TILES/striped_berry_rocket_tile.png | Striped berry finnes, men ikke egen rocket base. |
| special_rocket_horizontal.png | MANGLER |  | Ingen horisontal rocket-variant. |
| special_rocket_vertical.png | MANGLER |  | Ingen vertikal rocket-variant. |
| booster_hammer_icon.png | OK | booster_hammer_icon.png | Eksakt filnavn. |
| booster_magic_glove_icon.png | OK - annet navn | sprite sheet.png | Bildet er en magisk hanske; bør renames/croppes hvis nødvendig. |
| booster_paint_brush_icon.png | OK | booster_paint_brush_icon.png | Eksakt filnavn. |
| companion_bear_base.png | OK - annet navn | Cbear1.png | Bjørnekompanjong finnes under annet navn. |
| ui_booster_bar_panel.png | OK | ui_booster_bar_panel.png | Eksakt filnavn. |
| ui_pause_popup.png | OK | ui_pause_popup.png | Eksakt filnavn. |
| ui_level_start_popup.png | OK | ui_level_start_popup.png | Eksakt filnavn. |
| ui_level_complete_popup.png | OK | ui_level_complete_popup.png | Eksakt filnavn. |
| ui_level_failed_popup.png | OK | ui_level_failed_popup.png | Eksakt filnavn. |
| ui_out_of_moves_popup.png | OK | ui_out_of_moves_popup.png | Eksakt filnavn. |
| ui_reward_popup.png | OK | ui_reward_popup.png | Eksakt filnavn. |
| ui_chest_open_popup.png | OK | ui_chest_open_popup.png | Eksakt filnavn. |
| ui_daily_reward_popup.png | OK | ui_daily_reward_popup.png | Eksakt filnavn. |
| ui_friend_challenge_popup.png | OK | ui_friend_challenge_popup.png | Eksakt filnavn. |
| ui_challenge_result_popup.png | OK | ui_challenge_result_popup.png | Eksakt filnavn. |
| ui_wardrobe_popup.png | OK | ui_wardrobe_popup.png | Eksakt filnavn. |
| ui_event_popup.png | OK | ui_event_popup.png | Eksakt filnavn. |
| ui_button_primary.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_.png | Grønn tom primærknapp. |
| ui_button_secondary.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (1).png | Lys/tan sekundærknapp eller rad. |
| ui_button_disabled.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (3).png | Grå disabled-knapp. |
| ui_button_close.png | MANGLER |  | Ingen klar X/lukk-knapp. |
| ui_button_play.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (5).png | Rund play-knapp. |
| ui_button_retry.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (6).png | Rund retry-knapp. |
| ui_button_continue.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (7).png | Rund pil/continue-knapp. |
| ui_button_challenge_friend.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (8).png | Knapp med to venner/figurer. |
| ui_button_claim.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (9).png | Knapp med kurv/claim-symbol. |
| ui_button_equip.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (11).png | Knapp med antrekk/dress. |
| ui_button_buy.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (10).png | Knapp med coin-symbol. |
| ui_button_rematch.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (12).png | Knapp med rematch/repeat-symbol. |
| icon_coin.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (13).png | Myntikon. |
| icon_star.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (15).png | Stjerneikon. |
| icon_trophy.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (14).png | Trofeikon. |
| icon_honey_token.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (17).png | Honning-token. |
| icon_cosmetic_shard.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (16).png | Krystall/shard. |
| icon_booster_fragment.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (19).png | Grønt fragment/emblem. |
| icon_key.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (18).png | Nøkkelikon. |
| icon_heart_life.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (20).png | Hjerte/life. |
| chest_small_closed.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (21).png | Lukket skogskiste. |
| chest_small_open.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (22).png | Åpen skogskiste. |
| chest_star_closed.png | MANGLER |  | Fant åpen star chest i kombinert bilde, men ikke lukket separat star chest. |
| chest_star_open.png | DELVIS | unsorted/Gemini_Generated_Image_ (23).png / unsorted/Gemini_Generated_Image_ (24).png | Finnes som høyre del av kombinert bilde; må croppes. |
| chest_friend_closed.png | DELVIS | unsorted/Gemini_Generated_Image_ (23).png / unsorted/Gemini_Generated_Image_ (24).png | Finnes som venstre del av kombinert bilde; må croppes. |
| chest_friend_open.png | MANGLER |  | Ingen tydelig åpen friend chest. |
| chest_event_closed.png | MANGLER |  | Ingen tydelig event chest. |
| chest_event_open.png | MANGLER |  | Ingen tydelig event chest. |
| chest_rare_closed.png | MANGLER |  | Ingen tydelig rare chest. |
| chest_rare_open.png | MANGLER |  | Ingen tydelig rare chest. |
| challenge_invite_panel.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (2).png | Blank panel som passer best som challenge/invite panel. |
| challenge_result_panel.png | DELVIS | unsorted/Gemini_Generated_Image_ (1).png | Blank panel/rad kan brukes, men ikke tydelig result-panel. |
| challenge_leaderboard_panel.png | MANGLER |  | Ingen tydelig leaderboard-panel. |
| challenge_timer_badge.png | MANGLER |  | Ingen timer/klokke-badge. |
| challenge_same_seed_badge.png | MANGLER |  | Ingen tydelig same-seed badge. |
| challenge_fair_mode_badge.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (4).png | Rund badge med kryssede grener; passer best som fair-mode badge. |
| challenge_win_banner.png | MANGLER |  | Ingen win banner. |
| challenge_lose_banner.png | MANGLER |  | Ingen lose banner. |
| challenge_draw_banner.png | MANGLER |  | Ingen draw banner. |
| challenge_new_record_banner.png | MANGLER |  | Ingen new-record banner. |
| leaderboard_row_normal.png | VISUELL MATCH | unsorted/Gemini_Generated_Image_ (1).png | Lys/tan radpanel. |
| leaderboard_row_self.png | MANGLER |  | Ingen egen self-radvariant. |
| leaderboard_row_friend.png | MANGLER |  | Ingen egen friend-radvariant. |
| leaderboard_rank_badge_1.png | MANGLER |  | Ingen nummerert rank badge. |
| leaderboard_rank_badge_2.png | MANGLER |  | Ingen nummerert rank badge. |
| leaderboard_rank_badge_3.png | MANGLER |  | Ingen nummerert rank badge. |

## Usorterte bilder brukt som visuelle matcher

Jeg laget også en kontaktoversikt for rask kontroll:

`unsorted_contact_sheet.png`
