## Neutral NPCs
NPCs will not attack anything unless they are attacked first, then if the animal loses sight of its last attacker for more than 30 seconds (default), it will forget.

### Permissions
* `neutralnpcs.use` - those without this permission will not be affected by this plugin and will always experience default behaviour.

### Configuration

```json
{
  "Forget time": 30.0,
  "Only animals": true,
  "Affect only selected": false,
  "Selected entities": [ ]
}
```

* **Forget time** - The amount of time a player is considered hostile before returning to neutral.

* **Only animals** - If you want this plugin to only affect animals (like previous versions) then set this to true. Setting this to false will mean all NPCs will act neutral (includes bradley apc and patrol helicopter).

* **Affect only Selected** - If you want this plugin to only affect certain entitites, then this can be set to true, it will then only affect the entities defined in "Selected entities". **Note: (Only animals must be set to false)**

* **Selected entities** - Here is where you put the shortnames of the entities you want to be affected by the plugin (needs above permission set to true to have any effect).

Example of "Selected entities":

```json
...
  "Selected entities": [
    "bradleyapc",
    "patrolhelicopter"
  ]
}
```



## Neutral Animals
`This is for the old version of this plugin that only supported animals, found on the "neutralanimals" branch under the updates tab or version 1.* on under the main branch`

Animals will not attack anything unless they are attacked first, then if the animal loses sight of its last attacker for more than 30 seconds (default), it will forget.

### Permissions
* `neutralanimals.use` - those without this permission will not be affected by this plugin and will always experience default behaviour.

### Configuration

```json
{
  "Forget time": 30.0
}
```

* **Forget time** - The amount of time a player is considered hostile before returning to neutral.

## Notes
Thanks to `titanium47` for suggesting the original Neutral Animals plugin.

Thanks to [Bobby1](https://umod.org/user/Bobby1) for suggesting Neutral NPCs.