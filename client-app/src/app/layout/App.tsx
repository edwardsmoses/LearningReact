import React, { useState, useEffect } from "react";
import axios from "axios";
import { Header, Icon, List } from "semantic-ui-react";
import { IActivity } from "../modules/activity";

const App = () => {
  const [activities, setActivities] = useState<IActivity[]>([]);

  useEffect(() => {
    axios
      .get<IActivity[]>("http://localhost:5000/api/Activities")
      .then(response => {
        setActivities(response.data);
      });
  }, []);

  return (
    <div>
      <Header as="h2">
        <Icon name="users" />
        <Header.Content>Learning Reactivities</Header.Content>
      </Header>

      <List>
        {activities.map(activity => (
          <List.Item key={activity.id}>
            <List.Icon name="user" />
            <List.Content>
              {activity.title} - {activity.description}
            </List.Content>
          </List.Item>
        ))}
      </List>
    </div>
  );
};

export default App;
