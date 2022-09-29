import { createSelector } from '@ngrx/store';
import { Hotel } from '../infrastructure/models/hotel';

export interface IAppState {
  hotels?: Hotel[];
  hotelDetails?: Hotel;
}

export const selectAppState = (state: any) => {
  return state.AppState;
};

export const selectHotels = createSelector(
  selectAppState,
  (state: IAppState) => state?.hotels
);

export const selectHotelDetails = createSelector(
  selectAppState,
  (state: IAppState) => state?.hotelDetails
);
