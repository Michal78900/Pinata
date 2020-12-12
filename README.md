# Pinata
This is my first published plugin

# Config:
pinata:

  is_enabled: true
  
   A percentage chance to become a Pinata
   
  chance: 50
  
   How many items the Pinata will contain (max 8)
  item_amount: 8
  
   A hint message that will be desplayed to Pinata (leave empty to disable)
  hint_message: You have became the Pinata!
  
   Duration of the hint messeage
  hint_duration: 5
  
   List of SCPs that can become Pinata:
  s_c_p_roles:
  
  - Scp049
  - Scp0492
  - Scp096
  - Scp106
  - Scp173
  - Scp93953
  - Scp93989
  
   List of avabile items which Pinata can contain:
   
  items:
  - Adrenaline
  - KeycardJanitor
  - KeycardScientist
  - KeycardScientistMajor
  - KeycardZoneManager
  - KeycardGuard
  - KeycardSeniorGuard
  - KeycardContainmentEngineer
  - KeycardNTFLieutenant
  - KeycardNTFCommander
  - KeycardFacilityManager
  - KeycardChaosInsurgency
  - KeycardO5
  - Radio
  - GunCOM15
  - Medkit
  - Flashlight
  - MicroHID
  - SCP500
  - SCP207
  - WeaponManagerTablet
  - GunE11SR
  - GunProject90
  - Ammo556
  - GunMP7
  - GunLogicer
  - GrenadeFrag
  - GrenadeFlash
  - Disarmer
  - Ammo762
  - Ammo9mm
  - GunUSP
  - SCP018
  - SCP268
  - Adrenaline
  - Painkillers
  - Coin
  
 | Name | Type | Description | Default |
| --- | --- | --- | --- |
| is_enabled | bool | Is the plugin enabled | true |
| chance | uint | A percentage chance to become a Pinata | 50 |
| item_amount | uint | How many items the Pinata will contain (max 8) | 8 |
| hint_message | string | A hint message that will be desplayed to Pinata (leave empty to disable) | "You have became the Pinata!" |
| hint_duration  | uint | Duration of the hint messeage | 5 |
| s_c_p_roles | List | List of SCPs that can become Pinata | - Scp049
  - Scp0492
  - Scp096
  - Scp106
  - Scp173
  - Scp93953
  - Scp93989 |
