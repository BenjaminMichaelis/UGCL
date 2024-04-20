import * as $metadata from './metadata.g'
import * as $models from './models.g'
import { AxiosPromise, AxiosRequestConfig, ModelApiClient, ServiceApiClient, ItemResult, ListResult } from 'coalesce-vue/lib/api-client'

export class MatchApiClient extends ModelApiClient<$models.Match> {
  constructor() { super($metadata.Match) }
}


export class PlayerApiClient extends ModelApiClient<$models.Player> {
  constructor() { super($metadata.Player) }
}


export class TeamApiClient extends ModelApiClient<$models.Team> {
  constructor() { super($metadata.Team) }
}


