import { Action, createReducer, on } from '@ngrx/store';
import { IAppState } from './app.index';
import * as AppActions from './app.actions';
import { state } from '@angular/animations';

export const initialState: IAppState = {
  hotelDetails: {},
  hotels: [],
};

const _appReducer = createReducer(
  initialState,
  on(AppActions.setHotels, (state, { hotels }) => ({
    ...state,
    hotels: hotels,
  })),
  on(AppActions.setHotelDetails, (state, { hotel }) => ({
    ...state,
    hotelDetails: hotel,
  }))
);

export function appReducer(state: IAppState, action: Action) {
  return _appReducer(state, action);
}
