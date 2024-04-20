import * as metadata from './metadata.g'
import { Model, DataSource, convertToModel, mapToModel } from 'coalesce-vue/lib/model'

export interface Match extends Model<typeof metadata.Match> {
  matchId: number | null
  team1Id: number | null
  team1: Team | null
  team2Id: number | null
  team2: Team | null
  matchDate: Date | null
  team1Score: number | null
  team2Score: number | null
}
export class Match {
  
  /** Mutates the input object and its descendents into a valid Match implementation. */
  static convert(data?: Partial<Match>): Match {
    return convertToModel(data || {}, metadata.Match) 
  }
  
  /** Maps the input object and its descendents to a new, valid Match implementation. */
  static map(data?: Partial<Match>): Match {
    return mapToModel(data || {}, metadata.Match) 
  }
  
  /** Instantiate a new Match, optionally basing it on the given data. */
  constructor(data?: Partial<Match> | {[k: string]: any}) {
    Object.assign(this, Match.map(data || {}));
  }
}


export interface Player extends Model<typeof metadata.Player> {
  playerId: number | null
  name: string | null
}
export class Player {
  
  /** Mutates the input object and its descendents into a valid Player implementation. */
  static convert(data?: Partial<Player>): Player {
    return convertToModel(data || {}, metadata.Player) 
  }
  
  /** Maps the input object and its descendents to a new, valid Player implementation. */
  static map(data?: Partial<Player>): Player {
    return mapToModel(data || {}, metadata.Player) 
  }
  
  /** Instantiate a new Player, optionally basing it on the given data. */
  constructor(data?: Partial<Player> | {[k: string]: any}) {
    Object.assign(this, Player.map(data || {}));
  }
}


export interface Team extends Model<typeof metadata.Team> {
  teamId: number | null
  player1Id: number | null
  player1: Player | null
  player2Id: number | null
  player2: Player | null
}
export class Team {
  
  /** Mutates the input object and its descendents into a valid Team implementation. */
  static convert(data?: Partial<Team>): Team {
    return convertToModel(data || {}, metadata.Team) 
  }
  
  /** Maps the input object and its descendents to a new, valid Team implementation. */
  static map(data?: Partial<Team>): Team {
    return mapToModel(data || {}, metadata.Team) 
  }
  
  /** Instantiate a new Team, optionally basing it on the given data. */
  constructor(data?: Partial<Team> | {[k: string]: any}) {
    Object.assign(this, Team.map(data || {}));
  }
}


