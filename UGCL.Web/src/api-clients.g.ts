import * as $metadata from './metadata.g'
import * as $models from './models.g'
import { AxiosPromise, AxiosRequestConfig, ModelApiClient, ServiceApiClient, ItemResult, ListResult } from 'coalesce-vue/lib/api-client'

export class MatchApiClient extends ModelApiClient<$models.Match> {
  constructor() { super($metadata.Match) }
}


export class PersonApiClient extends ModelApiClient<$models.Person> {
  constructor() { super($metadata.Person) }
}


export class TeamApiClient extends ModelApiClient<$models.Team> {
  constructor() { super($metadata.Team) }
}


