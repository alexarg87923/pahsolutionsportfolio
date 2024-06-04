import React from 'react';
import App from 'App';
import paths from './paths';
import { Navigate, createBrowserRouter } from 'react-router-dom';

import Landing from 'components/pages/landing/Landing';

const routes = [
  {
    element: <App />,
    children: [
      {
        path: 'landing',
        element: <Landing />
      },
      {
        path: '*',
        element: <Navigate to={paths.error404} replace />
      }
    ]
  }
];

export const router = createBrowserRouter(routes, {
  basename: process.env.PUBLIC_URL
});

export default routes;
