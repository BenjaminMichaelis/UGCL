import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ServiceViewModel, DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface MatchViewModel extends $models.Match {
  matchId: number | null;
  team1Id: number | null;
  team1: TeamViewModel | null;
  team2Id: number | null;
  team2: TeamViewModel | null;
  matchDate: Date | null;
  team1Score: number | null;
  team2Score: number | null;
}
export class MatchViewModel extends ViewModel<$models.Match, $apiClients.MatchApiClient, number> implements $models.Match  {
  
  constructor(initialData?: DeepPartial<$models.Match> | null) {
    super($metadata.Match, new $apiClients.MatchApiClient(), initialData)
  }
}
defineProps(MatchViewModel, $metadata.Match)

export class MatchListViewModel extends ListViewModel<$models.Match, $apiClients.MatchApiClient, MatchViewModel> {
  
  constructor() {
    super($metadata.Match, new $apiClients.MatchApiClient())
  }
}


export interface PersonViewModel extends $models.Person {
  personId: number | null;
  name: string | null;
  birthDate: Date | null;
}
export class PersonViewModel extends ViewModel<$models.Person, $apiClients.PersonApiClient, number> implements $models.Person  {
  
  constructor(initialData?: DeepPartial<$models.Person> | null) {
    super($metadata.Person, new $apiClients.PersonApiClient(), initialData)
  }
}
defineProps(PersonViewModel, $metadata.Person)

export class PersonListViewModel extends ListViewModel<$models.Person, $apiClients.PersonApiClient, PersonViewModel> {
  
  constructor() {
    super($metadata.Person, new $apiClients.PersonApiClient())
  }
}


export interface TeamViewModel extends $models.Team {
  teamId: number | null;
  player1Id: number | null;
  player1: PersonViewModel | null;
  player2Id: number | null;
  player2: PersonViewModel | null;
}
export class TeamViewModel extends ViewModel<$models.Team, $apiClients.TeamApiClient, number> implements $models.Team  {
  
  constructor(initialData?: DeepPartial<$models.Team> | null) {
    super($metadata.Team, new $apiClients.TeamApiClient(), initialData)
  }
}
defineProps(TeamViewModel, $metadata.Team)

export class TeamListViewModel extends ListViewModel<$models.Team, $apiClients.TeamApiClient, TeamViewModel> {
  
  constructor() {
    super($metadata.Team, new $apiClients.TeamApiClient())
  }
}


const viewModelTypeLookup = ViewModel.typeLookup = {
  Match: MatchViewModel,
  Person: PersonViewModel,
  Team: TeamViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  Match: MatchListViewModel,
  Person: PersonListViewModel,
  Team: TeamListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
}

