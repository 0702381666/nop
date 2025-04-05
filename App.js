import React from 'react';
import { NavigationContainer, getFocusedRouteNameFromRoute } from '@react-navigation/native';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import HomeScreen from './app/screens/HomeScreen';
import OrderScreen from './app/screens/OrderScreen';
import CartScreen from './app/screens/CartScreen';
import { CartProvider } from './app/context/CartContext';
import { Ionicons, MaterialIcons, Feather } from '@expo/vector-icons';
import { View, Text } from 'react-native';

const Stack = createNativeStackNavigator();
const Tab = createBottomTabNavigator();

// Placeholder screens
const OrdersScreen = () => (
  <View style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
    <Text>Orders Screen</Text>
  </View>
);

const AccountScreen = () => (
  <View style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
    <Text>Account Screen</Text>
  </View>
);

const HomeStack = () => (
  <Stack.Navigator>
    <Stack.Screen name="HomeMain" component={HomeScreen} options={{ title: 'Menu' }} />
    <Stack.Screen name="Order" component={OrderScreen} options={{ title: 'Order' }} />
  </Stack.Navigator>
);

export default function App() {
  return (
    <CartProvider>
      <NavigationContainer>
        <Tab.Navigator
          screenOptions={({ route }) => ({
            headerShown: false,
            tabBarActiveTintColor: 'green',
            tabBarInactiveTintColor: 'gray',
            tabBarIcon: ({ color, size }) => {
              if (route.name === 'Stores') return <MaterialIcons name="store" size={size} color={color} />;
              if (route.name === 'Basket') return <Ionicons name="cart-outline" size={size} color={color} />;
              if (route.name === 'Orders') return <Feather name="file-text" size={size} color={color} />;
              if (route.name === 'Account') return <Ionicons name="person-outline" size={size} color={color} />;
            },
          })}
        >
          <Tab.Screen
            name="Stores"
            component={HomeStack}
            options={({ route }) => {
              const routeName = getFocusedRouteNameFromRoute(route) ?? 'HomeMain';
              const shouldHideTab = routeName === 'Order';
              return {
                tabBarStyle: shouldHideTab ? { display: 'none' } : undefined,
              };
            }}
          />
          <Tab.Screen name="Basket" component={CartScreen} />
          <Tab.Screen name="Orders" component={OrdersScreen} />
          <Tab.Screen name="Account" component={AccountScreen} />
        </Tab.Navigator>
      </NavigationContainer>
    </CartProvider>
  );
}