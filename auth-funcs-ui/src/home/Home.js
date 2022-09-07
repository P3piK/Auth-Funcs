import React, { useState } from 'react';
import './Home.css';
import { DefaultAuthPanel, RegisterPanel, LogInPanel } from './AuthPanels';

const Home = () => {
  const [authPanelId, setAuthPanelId] = useState(0);

  var handleAuthPanel = (id) =>
  {
    console.log({id});
    setAuthPanelId(id);
  }

  var authPanel = () => {
    return authPanelId === 1 ? <RegisterPanel handleAuthPanel={handleAuthPanel} /> : 
      authPanelId === 2 ? <LogInPanel handleAuthPanel={handleAuthPanel} /> : 
        <DefaultAuthPanel handleAuthPanel={handleAuthPanel} />;
  }

  return <div className="main-border">
    <main>
      <div className="cards">Cards</div>
      {authPanel()}
    </main>
  </div>;
}

export default Home;
