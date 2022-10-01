import { createSelector } from '@ngrx/store';
import { IHotel } from '../infrastructure/models/hotel';

export interface IAppState {
  hotels?: IHotel[];
  hotelDetails?: IHotel;
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
