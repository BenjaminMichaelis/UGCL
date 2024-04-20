import {
  Domain, getEnumMeta, solidify, ModelType, ObjectType,
  PrimitiveProperty, ForeignKeyProperty, PrimaryKeyProperty,
  ModelCollectionNavigationProperty, ModelReferenceNavigationProperty,
  HiddenAreas, BehaviorFlags
} from 'coalesce-vue/lib/metadata'


const domain: Domain = { enums: {}, types: {}, services: {} }
export const Match = domain.types.Match = {
  name: "Match",
  displayName: "Match",
  get displayProp() { return this.props.matchId }, 
  type: "model",
  controllerRoute: "Match",
  get keyProp() { return this.props.matchId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    matchId: {
      name: "matchId",
      displayName: "Match Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    team1Id: {
      name: "team1Id",
      displayName: "Team 1 Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.Team as ModelType).props.teamId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Team as ModelType) },
      get navigationProp() { return (domain.types.Match as ModelType).props.team1 as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Team1 is required.",
      }
    },
    team1: {
      name: "team1",
      displayName: "Team1",
      type: "model",
      get typeDef() { return (domain.types.Team as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.Match as ModelType).props.team1Id as ForeignKeyProperty },
      get principalKey() { return (domain.types.Team as ModelType).props.teamId as PrimaryKeyProperty },
      dontSerialize: true,
    },
    team2Id: {
      name: "team2Id",
      displayName: "Team 2 Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.Team as ModelType).props.teamId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Team as ModelType) },
      get navigationProp() { return (domain.types.Match as ModelType).props.team2 as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Team2 is required.",
      }
    },
    team2: {
      name: "team2",
      displayName: "Team2",
      type: "model",
      get typeDef() { return (domain.types.Team as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.Match as ModelType).props.team2Id as ForeignKeyProperty },
      get principalKey() { return (domain.types.Team as ModelType).props.teamId as PrimaryKeyProperty },
      dontSerialize: true,
    },
    matchDate: {
      name: "matchDate",
      displayName: "Match Date",
      type: "date",
      dateKind: "datetime",
      role: "value",
    },
    team1Score: {
      name: "team1Score",
      displayName: "Team 1 Score",
      type: "number",
      role: "value",
    },
    team2Score: {
      name: "team2Score",
      displayName: "Team 2 Score",
      type: "number",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Person = domain.types.Person = {
  name: "Person",
  displayName: "Person",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Person",
  get keyProp() { return this.props.personId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    personId: {
      name: "personId",
      displayName: "Person Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
    birthDate: {
      name: "birthDate",
      displayName: "Birth Date",
      type: "date",
      dateKind: "datetime",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Team = domain.types.Team = {
  name: "Team",
  displayName: "Team",
  get displayProp() { return this.props.teamId }, 
  type: "model",
  controllerRoute: "Team",
  get keyProp() { return this.props.teamId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    teamId: {
      name: "teamId",
      displayName: "Team Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    player1Id: {
      name: "player1Id",
      displayName: "Player 1 Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.Person as ModelType).props.personId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Person as ModelType) },
      get navigationProp() { return (domain.types.Team as ModelType).props.player1 as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Player1 is required.",
      }
    },
    player1: {
      name: "player1",
      displayName: "Player1",
      type: "model",
      get typeDef() { return (domain.types.Person as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.Team as ModelType).props.player1Id as ForeignKeyProperty },
      get principalKey() { return (domain.types.Person as ModelType).props.personId as PrimaryKeyProperty },
      dontSerialize: true,
    },
    player2Id: {
      name: "player2Id",
      displayName: "Player 2 Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.Person as ModelType).props.personId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Person as ModelType) },
      get navigationProp() { return (domain.types.Team as ModelType).props.player2 as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Player2 is required.",
      }
    },
    player2: {
      name: "player2",
      displayName: "Player2",
      type: "model",
      get typeDef() { return (domain.types.Person as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.Team as ModelType).props.player2Id as ForeignKeyProperty },
      get principalKey() { return (domain.types.Person as ModelType).props.personId as PrimaryKeyProperty },
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
  },
}

interface AppDomain extends Domain {
  enums: {
  }
  types: {
    Match: typeof Match
    Person: typeof Person
    Team: typeof Team
  }
  services: {
  }
}

solidify(domain)

export default domain as unknown as AppDomain
